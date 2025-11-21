const params = new URLSearchParams(window.location.search);
const digimonId = params.get("id");
const API_URL = `https://digi-api.com/api/v1/digimon/${digimonId}`;
const detailsContainer = document.getElementById("digimon-details");
const title = document.getElementById("digimon-name");

fetch(API_URL)
  .then(res => res.json())
  .then(data => renderDetails(data))
  .catch(() => {
    detailsContainer.innerHTML = "<p>Error loading Digimon details</p>";
  });

function renderDetails(d) {
  title.textContent = d.name;

  const levels = d.levels?.map(l => l.level).join(", ") || "Unknown";
  const attributes = d.attributes?.map(a => a.attribute).join(", ") || "Unknown";
  const types = d.types?.map(t => t.type).join(", ") || "Unknown";
  const fields = d.fields?.map(f => f.field).join(", ") || "Unknown";
  const description = d.descriptions?.find(desc => desc.language === "en_us")?.description || "No description available.";

  detailsContainer.innerHTML = `
    <div class="digimon-details-card">
      <img src="${d.images[0].href}" alt="${d.name}" />
      <div class="info">
        <h2>${d.name}</h2>
        <p><strong>Level:</strong> ${levels}</p>
        <p><strong>Attribute:</strong> ${attributes}</p>
        <p><strong>Type:</strong> ${types}</p>
        <p><strong>Field:</strong> ${fields}</p>
        <p class="description">${description}</p>
      </div>
    </div>
  `;
}