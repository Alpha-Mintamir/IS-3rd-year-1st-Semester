// farmer_dashboard.js





document.addEventListener('DOMContentLoaded', function () {
    var darkModeToggle = document.getElementById('darkModeToggle');

    
    function toggleDarkMode() {
        // Toggle dark mode by adding/removing a dark-mode class to the body
        document.body.classList.toggle('dark-mode');
    }

    // Add click event listener to the "Dark Mode" button
    darkModeToggle.addEventListener('click', toggleDarkMode);
});


document.addEventListener("DOMContentLoaded", function() {
    let link1 = document.querySelector(".link-1");
    let section1 = document.getElementById("0");
    let section2 = document.getElementById("1");
    let section3 = document.getElementById("2");
    let section4 = document.getElementById("3");

    // Initially, show section with id "0" and hide sections with ids "1" and "2"
    section1.style.display = "block";
    section2.style.display = "none";
    section3.style.display = "none";
    section4.style.display = "none";

    link1.addEventListener("click", function() {
        // Hide sections with ids "1" and "2"
        section1.style.display = "block";
        section2.style.display = "none";
        section3.style.display = "none";
        section4.style.display = "none";
    });
});


  
document.addEventListener("DOMContentLoaded", function() {
    let link2 = document.querySelector(".link-2");
    var section1 = document.getElementById("0");
    let section2 = document.getElementById("1");
    let section3 = document.getElementById("2");
    let section4 = document.getElementById("3");
    
  
    link2.addEventListener("click", function() {
      // Hide sections with ids "1" and "2"
      section1.style.display = "none";
      section3.style.display = "block";
      section2.style.display = "none";
      section4.style.display = "none";
    });
  });



  document.addEventListener("DOMContentLoaded", function() {
    let link3 = document.querySelector(".link-3");
    var section1 = document.getElementById("0");
    let section2 = document.getElementById("1");
    let section3 = document.getElementById("2");
    let section4 = document.getElementById("3");
    
    
  
    link3.addEventListener("click", function() {
      // Hide sections with ids "1" and "2"
      section1.style.display = "none";
      section3.style.display = "none";
      section2.style.display = "block";
      section4.style.display = "none";

    });
  });




  document.addEventListener("DOMContentLoaded", function() {
    let link3 = document.querySelector(".link-3");
    var section1 = document.getElementById("0");
    let section2 = document.getElementById("1");
    let section3 = document.getElementById("2");
    let section4 = document.getElementById("3");
    
    
  
    link3.addEventListener("click", function() {
      // Hide sections with ids "1" and "2"
      section1.style.display = "none";
      section3.style.display = "none";
      section2.style.display = "block"
      section4.style.display = "none";

    });
  });

  document.addEventListener("DOMContentLoaded", function() {
    let link4 = document.querySelector(".link-4");
    var section1 = document.getElementById("0");
    let section2 = document.getElementById("1");
    let section3 = document.getElementById("2");
    let section4 = document.getElementById("3");
    
    
  
    link4.addEventListener("click", function() {
      // Hide sections with ids "1" and "2"
      section1.style.display = "none";
      section3.style.display = "none";
      section2.style.display = "none"
      section4.style.display = "block";

    });
  });






  
  
