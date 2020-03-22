import { useEffect, useState } from 'react';

const useInfiniteScroll = () => {
    const [isEndOfPage, setIsEndOfPage] = useState(false);

    useEffect(() => {
        window.addEventListener('scroll', handleScroll);
        return () => window.removeEventListener('scroll', handleScroll);
    }, []);

    function handleScroll() {        
        if (isEndOfPage) return;

        if (window.innerHeight + document.documentElement.scrollTop + 200 
            < document.documentElement.offsetHeight) return;
        
        setIsEndOfPage(true);
    }

    function eventWasTrigger() {
        setIsEndOfPage(false);
    }

    return [isEndOfPage, eventWasTrigger];
 }

 export default useInfiniteScroll;