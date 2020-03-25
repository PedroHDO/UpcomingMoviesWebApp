
import config from '../config.json';
import HttpClient from '../common/httpClient';

const httpClient = new HttpClient(config.apiUrl);  

export default httpClient;