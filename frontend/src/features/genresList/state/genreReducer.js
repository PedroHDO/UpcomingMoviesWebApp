import initialState from './initialState';
import * as types from './actionTypes';

export default (state = initialState, action) => {
    switch (action.type) {
        case types.SET_GENRES : {
            const genres = action.payload;
            if (genres) {
                return { ...state, genres };
            }
            break;
        }
        default: return state;
    }
    
    return state;
}