import React, { useEffect, useState } from 'react';
import { connect } from 'react-redux';
import { movieService, genreService } from '../../../services';
import MoviesList from '../moviesList';
import * as types from '../../genresList/state/actionTypes';
import useInfiniteScroll from '../../../common/infiniteScroll';

const SearchMoviesList = ({ searchTerm, setGenres }) => { 
    const [data, setData] = useState([]);
    const [isFetching, setIsFetching] = useState(false);
    const [currentPage, setPage] = useState(1);    
    const [isEndOfPage, eventWasTrigger] = useInfiniteScroll();
    const startPage = 1;
    
    useEffect(() => {
         fetchData();
    }, [searchTerm]);    
    
    function fetchData() {
        fetchDataAsync();
    }

    async function fetchGenresAsync() {
        const genres = await genreService.list();
        setGenres(genres);
    }

    async function fetchDataAsync() {  
        setData([]);      
        setIsFetching(true);        
        await fetchGenresAsync();
        await fetchMoviesAsync(startPage);
    }

    async function fetchMoviesAsync(page) {
        const result = await movieService.search(searchTerm, page);
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
        setTimeout(() => { fetchMoviesAsync(currentPage + 1) }, 500);
    }

    return (
        <MoviesList movies={data} isFetching={isFetching} />
    );
}
const mapStateToProps = (props) => props;
const mapDispatchToProps = (dispatch) => {
    return {
        setGenres: (genres) => dispatch({ type: types.SET_GENRES, payload: genres }),
    }
 };

 export default connect(mapStateToProps, mapDispatchToProps)(SearchMoviesList);

