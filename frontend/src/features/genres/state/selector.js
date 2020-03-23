const getGenresState = store => {
    return store.genres;
}
const getGenresById = (genres, id) => {
    const selectedGenre = genres.find(genre => genre.id === id);
    return selectedGenre;
}

export { getGenresState, getGenresById };
