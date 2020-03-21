import axios from 'axios';
import queryString from 'query-string';
import config from '../config.json';

class Api 
{
    constructor() 
    {
        this.baseUrl = config.apiUrl;       
    }

    async getMovie(id)
    {
        const url = this.baseUrl + config.endpoints.movie + "/" + id; 
        const result = await axios(url);
        return result.data;
    }

    async getGenresList()
    {
        const url = this.baseUrl + config.endpoints.genre; 
        const result = await axios(url);
        return result.data;
    }

    async getUpcomingMovies(page,) 
    {       
        const parameters = { page };
        const stringfiedParameters = queryString.stringify(parameters);
        const url = this.baseUrl + config.endpoints.upcomingMovies + "?" + stringfiedParameters;  
        
        const result = await axios(url);
        
        return result.data;        
    }
    
    async searchMovies(searchTerm, page) 
    {       
        const parameters = { page, searchTerm };
        const stringfiedParameters = queryString.stringify(parameters);
        const url = this.baseUrl + config.endpoints.searchMovies + "?" + stringfiedParameters;  
        
        const result = await axios(url);
        
        return result.data;        
    }
}
const api = new Api();

export default api;