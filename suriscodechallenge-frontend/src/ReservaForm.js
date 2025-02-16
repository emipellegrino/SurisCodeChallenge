import React, { useState } from 'react';

function ReservaForm({ servicios, onReserva }) {
  const [formData, setFormData] = useState({
    servicioId: '',
    fechaInicial: '',
    fechaFinal: '',
    nombreCliente: ''
  });

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!formData.servicioId || !formData.fechaInicial || !formData.fechaFinal || !formData.nombreCliente) {
      alert('Por favor, complete todos los campos.');
      return;
    }
    
    const reserva = {
      cliente: formData.nombreCliente,
      servicioId: formData.servicioId,
      fechaInicial: new Date(formData.fechaInicial).toISOString(),
      fechaFinal: new Date(formData.fechaFinal).toISOString()
    };

    const jsonReserva = JSON.stringify(reserva);

    onReserva(JSON.parse(jsonReserva));
    setFormData({ servicioId: '', fechaInicial: '', fechaFinal: '', nombreCliente: '' });
  };

  return (
    <form onSubmit={handleSubmit} className="border p-4 rounded">
      <h2 className="mb-3">Hacer una Reserva</h2>
      <div className="mb-3">
        <select 
          className="form-select"
          value={formData.servicioId} 
          onChange={(e) => setFormData({ ...formData, servicioId: e.target.value })}
        >
          <option value="">Seleccione un servicio</option>
          {servicios.map(servicio => (
            <option key={servicio.id} value={servicio.id}>{servicio.nombre}</option>
          ))}
        </select>
      </div>
      <div className="mb-3">
        <input 
          type="datetime-local" 
          className="form-control"
          value={formData.fechaInicial} 
          onChange={(e) => setFormData({ ...formData, fechaInicial: e.target.value })}
        />
      </div>
      <div className="mb-3">
        <input 
          type="datetime-local" 
          className="form-control"
          value={formData.fechaFinal} 
          onChange={(e) => setFormData({ ...formData, fechaFinal: e.target.value })}
        />
      </div>
      <div className="mb-3">
        <input 
          type="text" 
          className="form-control"
          value={formData.nombreCliente} 
          onChange={(e) => setFormData({ ...formData, nombreCliente: e.target.value })}
          placeholder="Nombre del cliente"
        />
      </div>
      <button type="submit" className="btn btn-primary">Reservar</button>
    </form>
  );
}

export default ReservaForm;