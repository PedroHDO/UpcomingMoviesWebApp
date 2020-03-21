import React from 'react';
import UpcomingMoviesList from '../features/movie/upcomingMoviesList';

const UpcomingMoviesPage = () => {

    return (
        <div>
            <div className="App-header">
                <h2>Upcoming Movies</h2>
            </div>            
            <div >               
                <UpcomingMoviesList />  
            </div>
        </div>
    );
}

export default UpcomingMoviesPage;