function updateCities() {
    var regionSelect = document.getElementById('region');
    var citySelect = document.getElementById('city');
    var selectedRegion = regionSelect.value;
  
    // Clear previous city options
    citySelect.innerHTML = '<option value="">Select City</option>';
  
    // Add cities based on the selected region
    if (selectedRegion === 'amhara') {
      var amharaCities = ["Bahir Dar", "Gondar", "Dessie", "Debre Markos", "Debre Berhan", "Woldiya", "Kombolcha", "Lalibela", "Mekane Selam", "Injibara", "Finote Selam", "Debre Tabor", "Bure", "Debre Sina", "Debre Werk"];
      addCitiesToSelect(amharaCities);
    } else if (selectedRegion === 'oromia') {
      var oromiaCities = ["Adama (Nazret)", "Jimma", "Nekemte", "Bishoftu (Debre Zeyit)", "Shashamane", "Ambo", "Bule Hora", "Robe", "Asella", "Goba", "Bale Robe", "Negele Boran", "Guder", "Burayu", "Mojo"];
      addCitiesToSelect(oromiaCities);
    } else if (selectedRegion === 'sidama') {
      var sidamaCities = ["Hawassa", "Leku", "Yirgalem", "Dilla", "Aleta Wendo", "Bensa", "Wondo Genet", "Yirgacheffe", "Arbegona", "Chuko", "Hula"];
      addCitiesToSelect(sidamaCities);
    } else if (selectedRegion === 'snnpr') {
      var snnprCities = ["Kaffa", "Wolaita Sodo", "Arba Minch", "Sawla", "Dilla", "Dimeka", "Jinka", "Karati", "Gidole", "Soyama", "Kelle", "Laska"];
      addCitiesToSelect(snnprCities);
    }
  }
  
  function addCitiesToSelect(cities) {
    var citySelect = document.getElementById('city');
    cities.forEach(function (city) {
      var option = document.createElement('option');
      option.value = city;
      option.text = city;
      citySelect.add(option);
    });
  }
  


  var btn = document.getElementById("login_btn")

  var btn = document.getElementById("login_btn");

        
        btn.addEventListener("click", function() {
            
            window.location.href = "/Assets/farmer_dashboard.html";
        });