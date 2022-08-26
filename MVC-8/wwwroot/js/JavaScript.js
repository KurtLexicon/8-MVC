
/* === Post JSON Return HTML section - Helper === */

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
        var options = {
            method: 'POST',
            credentials: 'include',
            body: JSON.stringify(data),
            headers: {
                'Accept': 'text/html',
                'Content-type': 'application/json'
            }
        };

        let response = await fetch(url, options);

        if (response.ok) {
            return await response.text();
        } else if (response.error) {
            let errText = await response.error?.text();
            return errorHandler(errText ?
                `Error calling ${url}: ${errText}` :
                `Error calling ${url}: ${response.status} ${response.statusText}`);
        } else {
            return errorHandler(`Call to ${url}: ${response.status} ${response.statusText}`);
        }
    } catch {
        return errorHandler(`Call to ${url}: Network failure`);
    }
}

/* === Misc DOM === */

function selectName() {
    var elem = document.getElementById('Name');
    elem && elem.focus();
    elem.select();
}

function selectFilter() {
    var elem = document.getElementById('inputFilter');
    elem && elem.focus();
    elem.select();
}

function removeResponseMessage() {
    const elems = document.getElementsByClassName("messageContainer");
    for (let elem of elems) {
        elem.innerHTML = "";
    }
}

function closePersonView() {
    var elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox.innerHTML = '';
    selectFilter();
}

async function onEnterGetPeople(event) {
    if (event.key === "Enter") {
        getPeople();
    }
}

async function onEnterSave(event) {
    if (event.key === "Enter") {
        addOrUpdatePerson();
    }
}

/* === Handle Persons and Details === */

/* --- Show Details Box --- */

async function personDetails(elemWithIdValue) {
    var id = elemWithIdValue ? elemWithIdValue.value : 0;
    var text = await PostJson('/PersonDetails', { Id: id });

    var elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox.innerHTML = text;
    selectName();
}

/* --- Add random person --- */

async function addRandomPerson() {
    var text = await PostJson('/AddRandomPerson', {});

    var elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox.innerHTML = text;
    getPeople();
}

/* --- Add or update person --- */

async function addOrUpdatePerson() {
    var inputs = document.querySelectorAll('#personDetailForm input[type="text"]');
    var formData = {};
    for (var i = 0; i < inputs.length; i++) {
        formData[inputs[i].name] = inputs[i].value;
    }

    var text = await PostJson('/AddOrUpdatePerson', formData);

    var elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox.innerHTML = text;

    await getPeople();
    selectName();
}

/* --- Delete person --- */

async function removePerson(elemWithIdValue) {
    var id = elemWithIdValue.value;
    var elemFilter = document.getElementById('inputFilter');
    let filter = elemFilter ? elemFilter.value : '';

    var text = await PostJson('/DeletePerson', { id, filter });
    var elemPeopleList = document.getElementById('peopleList');
    elemPeopleList.innerHTML = text;
    selectFilter()
}

/* === Handle People List === */


async function getPeople() {
    var elemFilter = document.getElementById('inputFilter');
    let filter = elemFilter ? elemFilter.value : '';

    var text = await PostJson('/SetFilterGetPeopleList', { filter });

    var elemPeopleList = document.getElementById('peopleList');
    elemPeopleList.innerHTML = text;

    var newFilterElement = document.getElementById('inputFilter');
    newFilterElement && newFilterElement.focus();
}


/* === Some test functions === */

async function testUrlError() {
    var text = await PostJson('/SomethingStupid', {});
    var elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox.innerHTML = text;
}

async function testErrorCode() {
    var text = await PostJson('/TestErrorCode', {});
    var elemDetailsBox = document.getElementById('detailsBox');
    elemDetailsBox.innerHTML = text;
}

/* === When window loaded get people === */

window.addEventListener('load', () => {
    getPeople();
});

