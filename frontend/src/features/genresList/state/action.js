import * as types from './actionTypes';

const setGenres = genres => dispatch => dispatch({ type: types.SET_GENRES, payload: genres });


export {setGenres };

