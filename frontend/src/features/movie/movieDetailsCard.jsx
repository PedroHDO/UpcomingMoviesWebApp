import React from 'react';
import MovieImage from './movieImage';
import GenreList from '../genresList';
import DateFormater from '../../common/dateFormater';

const MovieDetailsCard = ({movie}) => {    
    return (
        <div className='row'>
            <div className='col-md-6'>
                <MovieImage imageSrc={movie.posterPath}/>
            </div>
            <div className='col-md-6'>
                <h1>{movie.title}</h1>             
                <p><strong>Realease date:</strong> <DateFormater dateToFormat={movie.releaseDate} /></p>
                <p><strong>Genre:</strong> <GenreList genreIds={movie.genreIds}/></p>
                <h3>Overview:</h3>
                <p>{movie.overview}</p>
            </div>
        </div>
    )
}

export default MovieDetailsCard;