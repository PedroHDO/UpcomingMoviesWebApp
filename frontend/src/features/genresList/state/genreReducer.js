import initialState from './initialState';
import * as types from './actionTypes';

export default (state = initialState, action) => {
    if (action.type === types.SET_IS_LOADING_GENRES) {
        return { ...state, isLoadingGenres: action.payload };
    }

    if (action.type === types.SET_GENRES) {
        const genres = action.payload;
        if (genres) {
            return { ...state, genres };
        }
    }

    return state;
}