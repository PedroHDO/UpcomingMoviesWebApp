import React from 'react';
import image from './loading.gif';

const Loading = () => {
    return (
        <div className='loading'>
            <img src={image} width='15px' alt='Loading'/>Loading...
        </div>);
}

export default Loading;