


function swapClasses(elem, c1, c2) {
    var classes = elem.classList;
    if (classes.contains(c1)) {
        elem.classList.remove(c1);
        elem.classList.add(c2);    
    } else {
        elem.classList.remove(c2);
        elem.classList.add(c1);    
    }
}

function replaceClass(elem, cFrom, cTo) {
    var classes = elem.classList;
    elem.classList.remove(cFrom);
    elem.classList.add(cTo);    
}


function toggleVisible(idToggle, idHide) {
    var elemHide = document.getElementById(idHide);
    replaceClass(elemHide, 'display_block', 'display_hidden');

    var elemToggle = document.getElementById(idToggle);
    swapClasses(elemToggle, 'display_block', 'display_hidden');
}

// AJAX

/*
function LoadData() {
    $("#tblStudent tbody tr").remove();
    $.ajax({
        type: 'POST',
        url: '@Url.Action("getStudent")',
        dataType: 'json',
        data: { id: '' },
        success: function (data) {
            var items = '';
            $.each(data, function (i, item) {
                var rows = "<tr>"
                    + "<td class='prtoducttd'>" + item.studentID + "</td>"
                    + "<td class='prtoducttd'>" + item.studentName + "</td>"
                    + "<td class='prtoducttd'>" + item.studentAddress + "</td>"
                    + "</tr>";
                $('#tblStudent tbody').append(rows);
            });
        },
        error: function (ex) {
            var r = jQuery.parseJSON(response.responseText);
            alert("Message: " + r.Message);
            alert("StackTrace: " + r.StackTrace);
            alert("ExceptionType: " + r.ExceptionType);
        }
    });
    return false;
}  

function DoAjax(callback) {
    $("#tblStudent tbody tr").remove();
    $.ajax({
        type: 'POST',
        url: '@Url.Action("getStudent")',
        dataType: 'json',
        data: { id: '' },
        success: function (data) {
            var items = '';
            $.each(data, function (i, item) {
                var rows = "<tr>"
                    + "<td class='prtoducttd'>" + item.studentID + "</td>"
                    + "<td class='prtoducttd'>" + item.studentName + "</td>"
                    + "<td class='prtoducttd'>" + item.studentAddress + "</td>"
                    + "</tr>";
                $('#tblStudent tbody').append(rows);
            });
        },
        error: function (ex) {
            var r = jQuery.parseJSON(response.responseText);
            alert("Message: " + r.Message);
            alert("StackTrace: " + r.StackTrace);
            alert("ExceptionType: " + r.ExceptionType);
        }
    });
    return false;
}
*/

async function callAjax(type, url, data) {
    jQuery.support.cors = true
    var ret = $.ajax({
        type,
        dataType: 'json',
        url,
        data,
    }).catch(err => { throw err });
    return ret
}

async function getJoke() {
    console.log('Calling ajax')
    try {
        var jokeResponse = await callAjax('get', '/api', '')
        console.log('Ajax returned')
        console.log(jokeResponse.message)
        return jokeResponse
    } catch (err) {
        console.log(err.message || err)
    }
}

async function getPeople(filter) {
    console.log('Calling ajax')
    try {
        var people = await callAjax('get', '/apiGetPeoplexxxx', '')
        console.log('Ajax returned')
        console.log(people)
        return people
    } catch (err) {
        console.log(err.message || err)
    }
}
