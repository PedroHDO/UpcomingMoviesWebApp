import React from 'react';
import { useHistory } from "react-router-dom";
import MovieImage from './movieImage.jsx';
import GenreList from '../genres/list';
import DateFormater from '../../common/dateFormater';

const MovieCard = ({movie}) => {  
    const history = useHistory();
    return (        
            <div key={movie.id} className="card-movie col-md-3 col-sm-6"
             onClick={() => history.push(`/details/${movie.id}`)}
             >
                <MovieImage imageSrc={movie.posterPath}/>
                <h5 className="card-title">{movie.title}</h5>
                <p><strong>Realease date:</strong> <DateFormater dateToFormat={movie.releaseDate} /></p>
                <p><strong>Genre:</strong> <GenreList genreIds={movie.genreIds}/></p>
            </div>
    );  
}

export default MovieCard;

