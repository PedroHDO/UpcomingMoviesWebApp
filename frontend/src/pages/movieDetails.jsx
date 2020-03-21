import React, { useEffect, useState }  from 'react';
import { useParams, useLocation } from 'react-router-dom';
import api from '../common/api';
import MovieDetailsCard from '../features/movie/movieDetailsCard';

const MovieDetails = () => {
    let { id } = useParams();
    const { location } = useLocation();
    const [movie, setMovie] = useState([]);
    const [isFetching, setIsFetching] = useState(true);
    useEffect(() => {
        fetchData();
    }, [location]);

    async function fetchData() {
        const result = await api.getMovie(id);
        setMovie(result);        
        setIsFetching(false);
    } 
    
    return (
        <div>
            <div className="App-header">            
                <h2>Movies Details</h2>
            </div>
            <br />
            {isFetching && (<span>Loading...</span>)}
            {!isFetching && (<MovieDetailsCard movie={movie} />)}            
        </div>
    );
}

export default MovieDetails;