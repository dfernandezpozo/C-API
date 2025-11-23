const API_URL = "https://digi-api.com/api/v1/digimon?pageSize=200";
const container = document.getElementById("digimon-container");
const lista = document.getElementById("listaDigimons");

async function loadDigimon() {
try {
  const res = await fetch(API_URL);
  
  if (!res.ok) throw new Error(`HTTP error! status: ${res.status}`);
  
  const data = await res.json();
  
  // AHORA LA API DEVUELVE: { content: [ ...digimons ] }
  const digimons = data.content;

  if (!Array.isArray(digimons)) {
    throw new Error("La API no devolvió una lista válida de Digimon.");
  }

  renderDigimon(digimons);

} catch (error) {
  console.error("Fetch error:", error);
}
}

function renderDigimon(digimons) {
  
  digimons.forEach(d => {
    const li = document.createElement("li");
    li.innerHTML = `
    <div class="digimon-card" onclick="goToDetails(${d.id})">
      <img src="${d.image}" alt="img"  onerror="this.src='./SinImagen.jpg' " />
      <h3>${d.name}</h3>
    </div>
  `;
    lista.appendChild(li);
  });
  
    container.appendChild(lista);
  

}

function goToDetails(id) {
window.location.href = `digimon.html?id=${id}`;
}

function searchDigimon() {
  const input = document.getElementById("searchInput").value.toLowerCase();

  if (input.trim() === "") {
    renderDigimon(digimonData); 
    return;
  }

  const filtrados = digimonData.filter(d =>
    d.name.toLowerCase().includes(input)
  );

  renderDigimon(filtrados);
}

function createSearchBar() {
  const searchBar = document.createElement("div");
  searchBar.classList.add("search-box");
  searchBar.innerHTML = `
    <input 
      type="text" 
      id="searchInput" 
      placeholder="Buscar Digimon..."
      oninput="searchDigimon()"
    />
  `;

  container.parentNode.insertBefore(searchBar, container);
}

createSearchBar();

loadDigimon();