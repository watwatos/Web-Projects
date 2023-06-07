 const inputBox  = document.getElementById('input-box')
 const listContainer = document.getElementById('list-container')
 var app = document.getElementById('todo-app');

 function addTask(){
    if(inputBox.value === ''){
        alert('please enter task first');
    }
    else{
        let li = document.createElement('li');
        li.innerText = inputBox.value;
        listContainer.appendChild(li);
        let span = document.createElement('span');
        span.innerText="X";
        li.appendChild(span);
    }
    inputBox.value='';
    saveData()
 }

 listContainer.addEventListener('click' , function(e){

    if(e.target.tagName==='LI'){
        e.target.classList.toggle('checked');
        
    }else if(e.target.tagName ==='SPAN'){
        e.target.parentElement.remove();
        
    }
    saveData()
 },false);



 


inputBox.addEventListener('keyup',(e)=>{
    if(e.keyCode===13){
        addTask();
    }
})

var root = document.querySelector(':root');
var checkBox = document.getElementById('darkmode-toggle');
var primary;
var font;

function changeBG(){
    root.style.setProperty('--color-primary',primary);
    root.style.setProperty('--color-font',font);
    
}
checkBox.addEventListener('click',()=>{

    if(checkBox.checked){
        primary='#242424';
        font='white';
        
        changeBG();
    }else{
        primary='white';
        font='rgb(43, 39, 39)';
        changeBG();
    }
    
    

})
function saveData(){
    localStorage.setItem('data',app.innerHTML);
    
 }
 function showTask(){
    listContainer.innerHTML=localStorage.getItem('data');
 }
showTask();