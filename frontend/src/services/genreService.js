import httpClient from './http';

class GenreService {    
    async list() {
        const result = await httpClient.getAsync("genre");
        return result.data;
    }
}
const genreService = new GenreService();

export default genreService;