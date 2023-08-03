
var close = document.getElementsByClassName("close");
document.addEventListener("click", function handleClick(event) {
    if (event.target.tagName === "LI") {
        event.target.classList.toggle('checked');
    }
});

document.addEventListener("keypress", function(event) {
    if (event.target.tagName === "INPUT") {
      if (event.key === "Enter") {
          newElement();
      }
    }
});

function newElement() {
    var li = document.createElement('li');
    var InputText = document.getElementById("MyInput").value;
    var t = document.createTextNode(InputText);
    if (InputText === "") {
        alert("Write something!");  
    } else {
        li.appendChild(t);
        document.getElementById("MyUL").appendChild(li);       
    }

    var span = document.createElement('span');
    var x = document.createTextNode('\u00d7');
    span.className = "close";
    span.appendChild(x);
    li.appendChild(span);
    document.getElementById("MyInput").value = "";

    for (var i = 0; i < close.length; i++) {
        let element = close[i].parentElement;
        close[i].onclick = function () {
            element.remove();
        }
    }
}

