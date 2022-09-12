
/* === GET / Post-JSON, Return HTML-section === */

async function doGet(url, params) {
    const options = {
        method: 'GET',
        credentials: 'include',
        headers: {
            'Accept': 'text/html',
        }
    };
    const fullUrl = addParams(url, params);
    return await doFetch(fullUrl, options);
}

async function doDelete(url, params) {
    const options = {
        method: 'DELETE',
        credentials: 'include',
        headers: {
            'Accept': 'text/html',
        }
    };
    const fullUrl = addParams(url, params);
    return await doFetch(fullUrl, options);
}



function addParams(url, params) {
    var queryParams = [];
    for (let key in params) {
        let str = `${key}=${encodeURIComponent(params[key])}`;
        queryParams.push(str);
    }
    return `${url}?${queryParams.join("&")}`;
}

async function doPost(url, data) {
    const options = {
        method: 'POST',
        credentials: 'include',
        body: JSON.stringify(data),
        headers: {
            'Accept': 'text/html',
            'Content-type': 'application/json'
        }
    };
    return await doFetch(url, options);
}

async function doFetch(url, options) {
    try {
        console.log(`Calling ${url}`);
        let response = await fetch(url, options);
        return handleResponse(url, response)
    } catch {
        return errorHandler(`Call to ${url}: Network failure`);
    }
}

async function handleResponse(url, response) {
    if (response.ok) {
        return await response.text();
    } else if (response.error) {
        let errText = await response.error?.text();
        return errorHandler(errText ?
            `Error calling ${url}: ${errText}` :
            `Error calling ${url}: ${response.status} ${response.statusText}`);
    } else {
        return errorHandler(`Error calling ${url}: ${response.status} ${response.statusText}`);
    }
}

function escape(htmlStr) {
    // https://www.educative.io/answers/how-to-escape-unescape-html-characters-in-string-in-javascript
    return htmlStr.replace(/&/g, '&amp;')
        .replace(/</g, '&lt;')
        .replace(/>/g, '&gt;')
        .replace(/"/g, '&quot;')
        .replace(/'/g, '&#39;');
}

function errorHandler(text) {
    console.log(text);
    return `<div class="errorMessage">${escape(text)}</div>`;
}

/* === Misc DOM === */

function entityCode() {
    const elem = document.getElementById('EntityCode');
    return elem && elem.dataset.itemCode;
}

function selectElement(id) {
    const elem = document.getElementById(id);
    elem && elem.focus();
    elem && elem.select();
}

function selectName() {
    selectElement('Name');
}

function selectFilter() {
    selectElement('inputFilter');
}

function getFilterText() {
    const elemFilter = document.getElementById('inputFilter');
    return elemFilter ? elemFilter.value : '';
}

function removeResponseMessage() {
    const elems = document.getElementsByClassName("messageContainer");
    for (let elem of elems) {
        elem.innerHTML = "";
    }
}

function setResponseMessage(id, innerHtml) {
    const elem = document.getElementById(id);
    elem && (elem.innerHTML = innerHtml);
}

function closeInputBox() {
    const elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox && (elemDetailsBox.innerHTML = '');
    selectFilter();
}

async function onEnterGetItems(event) {
    if (event.key === "Enter") {
        getItemsList();
    }
}

async function onEnterSaveItem(event) {
    if (event.key === "Enter") {
        addOrUpdateItem();
    }
}

function getRadioValue(name) {
    const elems = document.getElementsByName(name);
    const elem = elems && Array.from(elems).find(e => e.checked);
    return elem && elem.value || "";
}

/* === Handle Language pop up */

function editLanguagesOpen() {
    const elem = document.getElementById('languagePopup');
    elem && elem.classList.remove("visibilityHidden");
}

function editLanguagesClose() {
    const elem = document.getElementById('languagePopup');
    elem && elem.classList.add("visibilityHidden");
}

function getSelectTexts(select) {
    let options = select.options;
    let nOptions = options.length;

    let result = [];
    for (let i = 0; i < nOptions; i++) {
        let opt = options[i];
        if (opt.selected) {
            result.push(opt.text);
        }
    }
    return result.join(', ');
}


function changeLanguages() {
    const elemSelect = document.getElementById('LanguageIds');
    const elemLangStr = document.getElementById('strSelectedLanguages');
    elemSelect && elemLangStr && (elemLangStr.value = getSelectTexts(elemSelect));
}

/* === Handle Items === */

async function getItemsList() {
    const filterText = getFilterText();
    const category = getRadioValue('category-filter');
    const responseText = await doGet(`/${entityCode()}/GetList`, { filterText, category });

    const elemItemsList = document.getElementById('itemsList');
    elemItemsList && (elemItemsList.innerHTML = responseText);

    selectFilter()
}

async function getItem(id) {

    const text = await doPost(`/${entityCode()}/getItem`, id);

    const elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox && (elemDetailsBox.innerHTML = text);

    selectName();
}

async function setUserRole(id, role) {
    const filterText = getFilterText()
    const category = getRadioValue('radio-filter');;
    const responseText = await doPost(`/${entityCode()}/UpdateRole`, { id, role, filter: { filterText, category } });

    const elemItemsList = document.getElementById('itemsList');
    elemItemsList && (elemItemsList.innerHTML = responseText);
    selectFilter()
}

async function handleItemDeleted(id) {
    const elemId = document.getElementById('Id');
    const idValue = elemId ? elemId.value : '';
    if (id.toString() === idValue) {
        closeInputBox()
    }
}

async function removeItem(id) {
    const text = await doDelete(`/${entityCode()}/DeleteItem`, { id });

    if (text.includes('failMessage')) {
        setResponseMessage('listMessage', text)
    } else if (text.includes('errorMessage')) {
        const elemItemsList = document.getElementById('itemsList');
        elemItemsList && (elemItemsList.innerHTML = text);
    } else {
        await getItemsList(entityCode());
        handleItemDeleted(id)
    }
}

// https://stackoverflow.com/questions/5866169/how-to-get-all-selected-values-of-a-multiple-select-box
// Return an array of the selected option values
// select is an HTML select element
function getSelectValues(select) {
    let result = [];
    let options = select && select.options;
    let opt;

    for (let i = 0, iLen = options.length; i < iLen; i++) {
        opt = options[i];
        if (opt.selected) {
            result.push(opt.value || opt.text);
        }
    }
    return result;
}

async function addOrUpdateItem() {
    const formData = {};
    const inputs = document.querySelectorAll('#itemDetailForm input[type="text"]');
    for (let i = 0; i < inputs.length; i++) {
        formData[inputs[i].name] = inputs[i].value;
    }

    const selects = document.querySelectorAll('#itemDetailForm select');
    for (let i = 0; i < selects.length; i++) {
        if (selects[i].multiple) {
            formData[selects[i].name] = getSelectValues(selects[i]);
        } else {
            formData[selects[i].name] = selects[i].value;
        }
    }

    const id = parseInt(formData.id);
    const action = id === 0 ? 'AddItem' : 'UpdateItem';
    const text = await doPost(`/${entityCode()}/${action}`, formData);

    const elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox && (elemDetailsBox.innerHTML = text);

    await getItemsList(entityCode());

    selectName();
}

async function addRandomItem() {
    const text = await doPost(`/${entityCode()}/AddRandomItem`, {});

    const elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox && (elemDetailsBox.innerHTML = text);
    await getItemsList();
}

/* === Some test functions === */

async function testUrlError() {
    const text = await doPost('/SomethingStupid', {});
    const elemItemsList = document.getElementById('itemsList');
    elemItemsList && (elemItemsList.innerHTML = text);
}

async function testErrorCode() {
    const text = await doPost('/GetCoffee', {});
    const elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox && (elemDetailsBox.innerHTML = text);
}

/* === When window loaded fill items list === */

function initialLoad() {
    getItemsList();
}

window.addEventListener('load', () => {
    initialLoad();
});
