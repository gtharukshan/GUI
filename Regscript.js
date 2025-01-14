// Get today's date
const today = new Date();

// Format the date in dd/mm/yyyy format
const formattedDate = today.toLocaleDateString('en-GB');

// Set the value of the input field
document.getElementById('reg-date').value = formattedDate;
