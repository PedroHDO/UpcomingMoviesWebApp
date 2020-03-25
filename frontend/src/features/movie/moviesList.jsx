import React from 'react';
import MovieCard from './movieCard';
import Loading from '../../components/loading';

const MoviesList = ({ movies, isFetching }) => {
    return (
        <div className="row">
            {movies.map(movie => (
                <MovieCard key={movie.id} movie={movie}/>
            ))}
        {isFetching && <Loading />}
        </div>
    );
}

export default MoviesList;