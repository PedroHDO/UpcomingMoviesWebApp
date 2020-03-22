import React from 'react';
import noImage from './noImage.png';
import config from '../../config.json';

const MovieImage = ({imageSrc}) => {   
    const baseurl = config.apiUrl + "image/";    
    function getImageUrl()
    {
        if (imageSrc)
            return  baseurl + imageSrc;
        else 
            return noImage;
    }
    return (
        <div className="card-image">
            <img alt='poster' src={getImageUrl()} width="100%"/>
        </div>
    );
}

export default MovieImage;
