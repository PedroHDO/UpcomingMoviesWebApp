import queryString from 'query-string';
import httpClient from './http';

class MovieService {
    async get(id) {
        const url = `movie/${id}`; 
        const result = await httpClient.getAsync(url);
        return result.data;
    }

    async getUpcomingMovies(page) {       
        const parameters = queryString.stringify({ page });
        const url = `movie/upcoming?${parameters}`;  
        
        const result = await httpClient.getAsync(url);
        
        return result.data;        
    }
    
    async search(searchTerm, page) {       
        const parameters = { page, searchTerm };
        const stringfiedParameters = queryString.stringify(parameters);
        const url = `movie/search?${stringfiedParameters}`;  
        
        const result = await httpClient.getAsync(url);
        
        return result.data;        
    }
}

const movieService = new MovieService();

export default movieService;