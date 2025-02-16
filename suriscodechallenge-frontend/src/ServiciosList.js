import React from 'react';

function ServiciosList({ servicios }) {
  return (
    <div>
      <h2 className="mb-3">Servicios Disponibles</h2>
      <ul className="list-group">
        {servicios.map(servicio => (
          <li key={servicio.id} className="list-group-item">{servicio.nombre}</li>
        ))}
      </ul>
    </div>
  );
}

export default ServiciosList;