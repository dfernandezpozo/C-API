let lastDigimon = null;

async function buscarDigimon() {
    const input = document.getElementById("searchInput").value.trim();
    if (input === "") return;

    try {
        const res = await fetch(`https://digi-api.com/api/v1/digimon/${input}`);
        if (!res.ok) throw new Error("No encontrado");

        const digi = await res.json();
        lastDigimon = digi; // Guarda el Digimon encontrado

        mostrarDigimonCompleto(digi); // Muestra toda la info completa

        document.getElementById("filterMenu").style.display = "block";
    } catch {
        document.getElementById("result").innerHTML = "<p>No existe ese Digimon.</p>";
        document.getElementById("result").style.display = "block";
    }
}

function mostrarDigimonCompleto(d) {
    let html = `
        <h2>${d.name}</h2>
        <p><strong>Fecha de lanzamiento:</strong> ${d.releaseDate ?? "No disponible"}</p>
        <h3>Niveles:</h3>
        <ul>${(d.levels ?? []).map(x => `<li>${x.level}</li>`).join("")}</ul>
        <h3>Tipos:</h3>
        <ul>${(d.types ?? []).map(x => `<li>${x.type}</li>`).join("")}</ul>
        <h3>Atributos:</h3>
        <ul>${(d.attributes ?? []).map(x => `<li>${x.attribute}</li>`).join("")}</ul>
        <h3>Campos:</h3>
        <ul>${(d.fields ?? []).map(x => `<li>${x.field}</li>`).join("")}</ul>
        <h3>Descripciones:</h3>
        <ul>${(d.descriptions ?? []).map(x => `<li>[${x.origin}] ${x.description}</li>`).join("")}</ul>
        <h3>Skills:</h3>
        <ul>${(d.skills ?? []).map(x => `<li>${x.skill}: ${x.description}</li>`).join("")}</ul>
        <div class="image-container">
            ${(d.images ?? []).map(img => `<img src="${img.href}" alt="Digimon">`).join("")}
        </div>
    `;

    const target = document.getElementById("result");
    target.innerHTML = html;
    target.style.display = "block";
}

function mostrarFiltro(tipo) {
    if (!lastDigimon) return;

    const d = lastDigimon;
    let html = "<h2>Resultado filtrado</h2>";

    // Dependiendo del botón seleccionado, muestra una sección concreta
    switch (tipo) {
        case "release":
            html += `<p><strong>Fecha:</strong> ${d.releaseDate}</p>`;
            break;

        case "levels":
            html += `<ul>${d.levels.map(x => `<li>${x.level}</li>`).join("")}</ul>`;
            break;

        case "types":
            html += `<ul>${d.types.map(x => `<li>${x.type}</li>`).join("")}</ul>`;
            break;

        case "attributes":
            html += `<ul>${d.attributes.map(x => `<li>${x.attribute}</li>`).join("")}</ul>`;
            break;

        case "fields":
            html += `<ul>${d.fields.map(x => `<li>${x.field}</li>`).join("")}</ul>`;
            break;

        case "descriptions":
            html += `<ul>${d.descriptions.map(x => `<li>[${x.origin}] ${x.description}</li>`).join("")}</ul>`;
            break;

        case "skills":
            html += `<ul>${d.skills.map(x => `<li>${x.skill}: ${x.description}</li>`).join("")}</ul>`;
            break;

        case "images":
            html += d.images.map(img => `<img src="${img.href}" width="200">`).join("");
            break;
    }

    const target = document.getElementById("result");
    target.innerHTML = html;
    target.style.display = "block";
}