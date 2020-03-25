import  React from 'react';
import { connect } from 'react-redux';
import  { getGenresById } from './state/selector';

const GenreList = ({ genres, genreIds }) => {
    function getGenreName(genreId) {
        const genre = getGenresById(genres, genreId);
        if (genre)
            return genre.name;
    }

    if (!genreIds) {
        return (<span>Genre not informed.</span>);
    }

    const formattedGenres = genreIds.map(getGenreName).join(', ');

    return (<span>{formattedGenres}</span>);
}
  const mapStateToProps = (state, ownProps) => {          
    const isLoading = state.genre.isLoadingGenres;
    return { 
        genres: state.genre.genres,
        genreIds: ownProps.genreIds, 
        isLoading
    }
  }
  
  const connectToStore = connect(mapStateToProps);
  export default connectToStore(GenreList);
