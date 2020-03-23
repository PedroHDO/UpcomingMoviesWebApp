import React, { useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import {
  BrowserRouter as Router,
  Switch,
  Route,
} from 'react-router-dom';
import './App.css';
import NavbarMenu from './components/navbar';
import UpcomingMoviesPage from './pages/upcomingMovies';
import SearchMoviesPage from './pages/searchMovies';
import MovieDetails from './pages/movieDetails';
import useGenres from './features/genres/useGenres';

const App = () => {  
    const { fetchGenres } = useGenres();
    
    useEffect(() => {
        fetchGenres();        
    }, [fetchGenres]);  

    return (
      <Router>
        <div className='container'>
          <NavbarMenu />
          <Switch>
            <Route exact path='/details/:id'>
              <MovieDetails />
            </Route>
            <Route exact path='/search/'>
              <SearchMoviesPage />
            </Route> 
            <Route exact path='/'>
              <UpcomingMoviesPage />
            </Route>            
          </Switch>
          <footer className="footer">
            <p>Developed by <a href='https://github.com/PedroHDO/UpcomingMoviesWebApp'>@PedroHDO</a></p>
          </footer>
        </div>
      </Router>
    );  
}

export default App;
