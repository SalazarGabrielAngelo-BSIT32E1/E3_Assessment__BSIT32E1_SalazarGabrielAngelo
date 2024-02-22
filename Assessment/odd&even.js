function checkEvenOrOdd(number) {
    if (number % 2 === 0) {
      return "Even";
    } else {
      return "Odd";
    }
  }

  function displayResult() {
    var inputNumber = parseInt(document.getElementById("numInput").value);
    var result = checkEvenOrOdd(inputNumber);
    document.getElementById("result").innerText = "The number is " + result + ".";
  }