import  React from 'react';
import { connect } from 'react-redux';
import  { getGenresById } from './state/selector';

const GenreList = ({genres, genreIds, isLoading}) => {   
    
    function getGenreName(genreId) {
        const genre = getGenresById(genres, genreId);
        return genre.name;
    }
    return (
      <span>
        {genreIds && genreIds.map(getGenreName).join(', ')}
        {!genreIds && "Genre not informed."}
      </span>
      );
}
  const mapStateToProps = (state, ownProps) => {          
    const isLoading = state.genre.isLoadingGenres;
    return { 
        genres: state.genre.genres,
        genreIds : ownProps.genreIds, 
        isLoading
    }
  }
  
  const connectToStore = connect(mapStateToProps);
  export default connectToStore(GenreList);
