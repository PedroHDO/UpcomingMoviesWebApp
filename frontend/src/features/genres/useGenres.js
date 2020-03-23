import { useDispatch } from 'react-redux';
import { genreService } from '../../services';
import * as types from './state/actionTypes';

const useGenres = () => {
    const dispatch = useDispatch()

    async function fetchGenresAsync() {
        const genres = await genreService.list();
        dispatch({ type: types.SET_GENRES, payload: genres });
    }
    
    function fetchGenres() {
        fetchGenresAsync();
    }

    return { fetchGenres };
}

export default useGenres;