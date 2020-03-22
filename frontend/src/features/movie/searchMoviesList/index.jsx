import React, { useEffect, useState } from 'react';
import { connect } from 'react-redux';
import { movieService, genreService } from '../../../services';
import MoviesList from '../moviesList';
import * as types from '../../genresList/state/actionTypes';

const SearchMoviesList = ({ searchTerm, setGenres }) => { 
    const [data, setData] = useState([]);
    const [isFetching, setIsFetching] = useState(false);
    const [currentPage, setPage] = useState(1);
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
        setPage(page);
        setData(prevState => ([...prevState.concat(result)]));
            setIsFetching(false);
    }   
    
    useEffect(() => {
        if (!isFetching) return;
        fetchMoreListItems();
    }, [isFetching]);

    function fetchMoreListItems()
    {
        setTimeout(() => { fetchMoviesAsync(currentPage + 1) }, 500);
    }

    useEffect(() => {
        window.addEventListener('scroll', handleScroll);
        return () => window.removeEventListener('scroll', handleScroll);
    }, []);

    function handleScroll() {
        if (window.innerHeight + document.documentElement.scrollTop + 200 < document.documentElement.offsetHeight) return;
        setIsFetching(true);
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

