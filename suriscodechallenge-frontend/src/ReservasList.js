import React from 'react';

function ReservasList({ reservas }) {
  return (
    <div>
      <h2 className="mb-3">Reservas Existentes</h2>
      <ul className="list-group">
        {reservas.map(reserva => (
          <li key={reserva.id} className="list-group-item">
            {reserva.Cliente} - {new Date(reserva.fechaInicial).toLocaleString()} hasta {new Date(reserva.fechaFinal).toLocaleString()}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default ReservasList;