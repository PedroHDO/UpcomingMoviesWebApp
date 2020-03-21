import React, { useEffect, useState } from 'react';

const SearchBar = ({placeholder, onSearch, term}) => {
    const [searchTerm, setSearchTerm] = useState('');

    useEffect(() => {
        setSearchTerm(term);
    }, [term]);

    const handleSubmit = (event) => {
        event.preventDefault();
        onSearch(searchTerm);        
    }
    return (        
        <form onSubmit={handleSubmit}>
            <div className="box-search input-group">
                <input type="text" className="form-control" 
                    value={searchTerm}
                    placeholder={placeholder}
                    onChange={(event) => setSearchTerm(event.target.value)}
                />
                <div className="input-group-append">
                    <button className="btn btn-primary" type="submit">
                        Search
                    </button>
                </div>
            </div>
        </form>
        
    );
}
export default SearchBar;