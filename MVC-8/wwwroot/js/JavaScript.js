
/* === Post JSON Return HTML-section === */

function errorHandler(text) {
    function escape(htmlStr) {
        // https://www.educative.io/answers/how-to-escape-unescape-html-characters-in-string-in-javascript
        return htmlStr.replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
    }
    console.log(text);
    return `<div class="errorMessage">${escape(text)}</div>`;
}

async function PostJson(url, data) {
    try {
        if (url.startsWith('//')) {
            // This happens if EntityCode is missing for some reason
            throw 'Url starts with //';
        }

        const options = {
            method: 'POST',
            credentials: 'include',
            body: JSON.stringify(data),
            headers: {
                'Accept': 'text/html',
                'Content-type': 'application/json'
            }
        };
        console.log(`Calling ${url}`);
        let response = await fetch(url, options);

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
    } catch {
        return errorHandler(`Call to ${url}: Network failure`);
    }
}

/* === Misc DOM === */

function entityCode() {
    const elem = document.getElementById('EntityCode');
    return elem && elem.dataset.itemCode;
}

function selectName() {
    const elem = document.getElementById('Name');
    elem && elem.focus();
    elem && elem.select();
}

function selectFilter() {
    const elem = document.getElementById('inputFilter');
    elem && elem.focus();
    elem && elem.select();
}

function removeResponseMessage() {
    const elems = document.getElementsByClassName("messageContainer");
    for (let elem of elems) {
        elem.innerHTML = "";
    }
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

/* === Handle Language pop up */

function listBoxCLick(option) {
    // option.selected = !option.selected;
}

//function initSelectBox() {
//    document.addEventListener('keydown', event => {
//        try {
//            switch (event.key) {
//                case Key.ArrowUp:
//                case Key.ArrowDown:
//                case Key.ArrowLeft:
//                case Key.ArrowRight:
//                    handleArrowKey(event)
//                    event.preventDefault();
//                    break;
//                case Key.Enter:
//                    handleEnterKey()
//                    event.preventDefault();
//                    break;
//                default:
//            }
//        } catch (err) {
//            setStatusText(err)
//        }
//    });
//}

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

    const elemFilter = document.getElementById('inputFilter');
    const filter = elemFilter ? elemFilter.value : '';

    const text = await PostJson(`/${entityCode()}/GetItems`, filter);

    const elemItemsList = document.getElementById('itemsList');
    elemItemsList && (elemItemsList.innerHTML = text);

    selectFilter()
}

async function getItem(id) {

    const text = await PostJson(`/${entityCode()}/getItem`, id);

    const elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox && (elemDetailsBox.innerHTML = text);

    selectName();
}

async function removeItem(id) {
    const elemFilter = document.getElementById('inputFilter');
    const filter = elemFilter ? elemFilter.value : '';

    const text = await PostJson(`/${entityCode()}/DeleteItem`, { id, filter });

    const elemItemsList = document.getElementById('itemsList');
    elemItemsList && (elemItemsList.innerHTML = text);

    selectFilter()
}

// https://stackoverflow.com/questions/5866169/how-to-get-all-selected-values-of-a-multiple-select-box
// Return an array of the selected opion values
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

    const text = await PostJson(`/${entityCode()}/AddOrUpdateItem`, formData);

    const elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox && (elemDetailsBox.innerHTML = text);

    await getItemsList(entityCode());

    selectName();
}

async function addRandomItem() {
    const text = await PostJson(`/${entityCode()}/AddRandomItem`, {});

    const elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox && (elemDetailsBox.innerHTML = text);
    await getItemsList();
}

/* === Some test functions === */

async function testUrlError() {
    const text = await PostJson('/SomethingStupid', {});
    const elemItemsList = document.getElementById('itemsList');
    elemItemsList && (elemItemsList.innerHTML = text);
}

async function testErrorCode() {
    const text = await PostJson('/GetCoffee', {});
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
