import React, { useState, useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import ReservaForm from './ReservaForm';
import ServiciosList from './ServiciosList';
import ReservasList from './ReservasList';
import axios from 'axios';

axios.defaults.baseURL = 'http://localhost:5000';


function App() {
  const [servicios, setServicios] = useState([]);
  const [reservas, setReservas] = useState([]);

  useEffect(() => {
    // Obtener servicios
    axios.get('/api/Reservas/GetServicios')
      .then(response => setServicios(response.data))
      .catch(error => console.error('Error fetching servicios:', error));

    // Obtener reservas
    axios.get('/api/Reservas/GetReservas')
      .then(response => setReservas(response.data))
      .catch(error => console.error('Error fetching reservas:', error));
  }, []);

  const handleNewReserva = (reserva) => {
    // Crear reserva
    axios.post('/api/Reservas/InsertReserva', reserva)
      .then(response => {
        if (response.data.success) {
          setReservas([...reservas, response.data.reserva]);
          alert('Reserva creada con éxito');
        }
      })
      .catch(error => {
        alert(error.response.data || 'Error al crear la reserva');
      });
  };

  return (
    <div className="container mt-4">
      <h1 className="display-4 text-center mb-4">Gestión de Reservas</h1>
      <div className="row">
        <div className="col-md-6">
          <ServiciosList servicios={servicios} />
        </div>
        <div className="col-md-6">
          <ReservaForm servicios={servicios} onReserva={handleNewReserva} />
        </div>
      </div>
      <div className="mt-4">
        <ReservasList reservas={reservas} />
      </div>
    </div>
  );
}

export default App;