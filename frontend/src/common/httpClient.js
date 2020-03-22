import axios from 'axios';

class HttpClient { 

    constructor(baseUrl) {
        this.axiosInstance = axios.create({
                                baseURL: baseUrl,
                                timeout: 1000
                                });

    }

    async getAsync(path) {
        return await this.axiosInstance.get(path);
    }
}

export default HttpClient;