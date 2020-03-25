import React, { useState, useEffect } from 'react';
import { withRouter } from 'react-router-dom';
import queryString from 'query-string';
import SearchMoviesList from '../features/movie/searchMoviesList';
import SearchBar from '../components/forms/search/searchBar';

const SearchMoviesPage = ({history, location}) => {
    const [ searchTerm, setSearchTerm ] = useState('');
    
    useEffect(() => {        
        const search = queryString.parse(location.search);
        setSearchTerm(search.searchTerm);
    }, [location]);

    const onSearch = (searchTerm) => {
        const queryParameter = {searchTerm};
        const stringifiedParameter = queryString.stringify(queryParameter);
        history.push(`/search/?${stringifiedParameter}`);
    }
    
    return (
        <div>
            <div className="App-header">
            <h2>Movies search</h2>
            </div>            
            <div >
                <SearchBar placeholder="Search a movie by name"
                  onSearch={onSearch} 
                  term={searchTerm}
                  />
                {searchTerm && <SearchMoviesList searchTerm={searchTerm}/> }
            </div>
        </div>
    );
}

export default withRouter(SearchMoviesPage);