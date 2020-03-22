import queryString from 'query-string';
import config from '../config.json';
import HttpClient from '../common/httpClient';

class Api {
    constructor() {
        this.baseUrl = config.apiUrl; 
        this.httpClient = new HttpClient(this.baseUrl);   
    }

    async getMovie(id) {
        const url = config.endpoints.movie + "/" + id; 
        const result = await this.httpClient.getAsync(url);
        return result.data;
    }

    async getGenresList() {
        const url = this.baseUrl + config.endpoints.genre; 
        const result = await this.httpClient.getAsync(url);
        return result.data;
    }

    async getUpcomingMovies(page) {       
        const parameters = { page };
        const stringfiedParameters = queryString.stringify(parameters);
        const url = this.baseUrl + config.endpoints.upcomingMovies + "?" + stringfiedParameters;  
        
        const result = await this.httpClient.getAsync(url);
        
        return result.data;        
    }
    
    async searchMovies(searchTerm, page) {       
        const parameters = { page, searchTerm };
        const stringfiedParameters = queryString.stringify(parameters);
        const url = this.baseUrl + config.endpoints.searchMovies + "?" + stringfiedParameters;  
        
        const result = await this.httpClient.getAsync(url);
        
        return result.data;        
    }
}
const api = new Api();

export default api;