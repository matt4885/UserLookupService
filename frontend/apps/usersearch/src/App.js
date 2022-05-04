import './App.css';
import React from "react";

import { Home } from './Home';
import { Department } from './Department';
import { User } from './User';
import { Navigation } from './Navigation';

import { Route, Routes } from 'react-router-dom';
import { AddUser } from './AddUser';


function App() {
  return (

    <div className="app">
      <h2 className="m-3 d-flex justify-content-center">
        User Look Up Service
      </h2>

      <Navigation />

      <Routes>
        <Route path='/' element={<Home />} exact />
        <Route path='/department' element={<Department />} />
        <Route path='/user' element={<User />} />
        <Route path='/add-user' element={<AddUser />} />

      </Routes>
    </div>

  );
}

export default App;
