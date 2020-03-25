import React, { useEffect, useState } from 'react';
import { useLocation } from 'react-router-dom';
import { movieService } from '../../../services';
import MoviesList from '../moviesList';
import useInfiniteScroll from '../../../common/infiniteScroll';


const UpcomingMoviesList = ({ setGenres }) => { 
    const { location } = useLocation();
    const [data, setData] = useState([]);
    const [isFetching, setIsFetching] = useState(false);
    const [currentPage, setPage] = useState(1);
    const [isEndOfPage, eventWasTrigger] = useInfiniteScroll();
    const startPage = 1;
    
    useEffect(() => {    
        async function fetchDataAsync() {        
            setIsFetching(true);
            await fetchMoviesAsync(startPage);          
        }

        fetchDataAsync();
    }, [location]);    

    async function fetchMoviesAsync(page) {
        const result = await movieService.getUpcomingMovies(page);
        if (result.length) {
            setPage(page);
            setData(prevState => ([...prevState.concat(result)]));        
            eventWasTrigger();  
        }
        setIsFetching(false);    
    }   
    
    useEffect(() => {
        if (!isEndOfPage) return;
        fetchMoreListItems();
    }, [isEndOfPage]);

    function fetchMoreListItems()
    {
        setIsFetching(true);
        setTimeout(() => fetchMoviesAsync(currentPage + 1), 500);
    }   

    return (
        <MoviesList movies={data} isFetching={isFetching} />
    );
}


 export default UpcomingMoviesList;

