// exporter_product_specifications.js

// You can add more countries as needed
const countries = [
    'United States',
    'United Kingdom',
    'Germany',
    'France',
    'Italy',
    'Spain',
    'Canada',
    'Brazil',
    'Argentina',
];

function populateCountries() {
    const countrySelect = document.getElementById('exportTo');
    countries.forEach(country => {
        const option = document.createElement('option');
        option.value = country;
        option.textContent = country;
        countrySelect.appendChild(option);
    });
}

// Call the function to populate the "Export to" select element on page load
populateCountries();
