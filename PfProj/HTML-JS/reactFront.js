async function handleCharacterSubmit(e) {
  e.preventDefault();
  disable(textarea);
  disable(button);
  show(loadingMessage);
  hide(successMessage)
  hide(errorMessage);
  var radioValue = getRadioButtonValue();
  try {
    if (radioValue){
      await submitCharacterForm(textarea.value, radioValue);
      show(successMessage);
    }
    else
      throw new Error('No class is selected!');
  } catch (err) {
    show(errorMessage);
    errorMessage.textContent = err.message;
  } finally {
    hide(loadingMessage);
    enable(textarea);
    enable(button);
  }
}

function getRadioButtonValue() {
  var ele = document.getElementsByName('myRadio');
  for (i = 0; i < ele.length; i++) {
    if (ele[i].checked)
      return ele[i].value;
  }
  return null;
}

function handleTextareaChange() {
  if (textarea.value.length === 0) {
    disable(button);
  } else {
    enable(button);
  }
}

function hide(el) {
  el.style.display = 'none';
}

function show(el) {
  el.style.display = '';
}

function enable(el) {
  el.disabled = false;
}

function disable(el) {
  el.disabled = true;
}

// TODO: get form & post instead of get
async function submitCharacterForm(name, radioValue) {
  // Hit the network.
  await post(event,'characters', JSON.stringify({
    'name':name,
    'characterClassName':radioValue
  }))
  .then(response => {
    if (!response)
      throw new Error('Something went wrong; null response.')
  })
}


let form = document.getElementById('form');
let textarea = document.getElementById('textarea');
let button = document.getElementById('button');
let loadingMessage = document.getElementById('loading');
let errorMessage = document.getElementById('error');
let successMessage = document.getElementById('success');
form.onsubmit = handleCharacterSubmit;
textarea.oninput = handleTextareaChange;