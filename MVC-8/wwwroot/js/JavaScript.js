
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


async function onEnterGetItems(event, EntityCode) {
    if (event.key === "Enter") {
        getItemsList(EntityCode);
    }
}

async function onEnterSaveItem(event, EntityCode) {
    if (event.key === "Enter") {
        addOrUpdateItem(EntityCode);
    }
}

/* === Handle Items === */

async function getItemsList(EntityCode) {

    const elemFilter = document.getElementById('inputFilter');
    const filter = elemFilter ? elemFilter.value : '';

    const text = await PostJson(`/${EntityCode}/GetItems`, filter);

    const elemItemsList = document.getElementById('itemsList');
    elemItemsList && (elemItemsList.innerHTML = text);

    selectFilter()
}

async function getItem(EntityCode, id) {

    const text = await PostJson(`/${EntityCode}/getItem`, id);

    const elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox && (elemDetailsBox.innerHTML = text);

    selectName();
}

async function removeItem(EntityCode, id) {
    const elemFilter = document.getElementById('inputFilter');
    const filter = elemFilter ? elemFilter.value : '';

    const text = await PostJson(`/${EntityCode}/DeleteItem`, { id, filter });

    const elemItemsList = document.getElementById('itemsList');
    elemItemsList && (elemItemsList.innerHTML = text);

    selectFilter()
}


async function addOrUpdateItem(EntityCode) {
    const formData = {};
    const inputs = document.querySelectorAll('#itemDetailForm input[type="text"]');
    for (let i = 0; i < inputs.length; i++) {
        formData[inputs[i].name] = inputs[i].value;
    }
    const selects = document.querySelectorAll('#itemDetailForm select');
    for (let i = 0; i < selects.length; i++) {
        formData[selects[i].name] = selects[i].value;
    }

    const text = await PostJson(`/${EntityCode}/AddOrUpdateItem`, formData);

    const elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox && (elemDetailsBox.innerHTML = text);

    await getItemsList(EntityCode);

    selectName();
}

async function addRandomItem(EntityCode) {
    const text = await PostJson(`/${EntityCode}/AddRandomItem`, {});

    const elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox && (elemDetailsBox.innerHTML = text);
    await getItemsList(EntityCode);
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
    const elemEntityCode = document.getElementById('EntityCode');
    const EntityCode = elemEntityCode && elemEntityCode.getAttribute('data-item-code');
    EntityCode && getItemsList(EntityCode);
}

window.addEventListener('load', () => {
    initialLoad();
});
