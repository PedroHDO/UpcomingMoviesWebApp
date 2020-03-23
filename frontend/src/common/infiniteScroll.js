import { useEffect, useState } from 'react';

const useInfiniteScroll = () => {
    const [isEndOfPage, setIsEndOfPage] = useState(false);

    useEffect(() => {
        function handleScroll() {        
            if (isEndOfPage) return;
    
            if (window.innerHeight + document.documentElement.scrollTop + 200 
                < document.documentElement.offsetHeight) return;
            
            setIsEndOfPage(true);
        }
        
        window.addEventListener('scroll', handleScroll);
        return () => window.removeEventListener('scroll', handleScroll);
    }, []);

    

    function eventWasTrigger() {
        setIsEndOfPage(false);
    }

    return [isEndOfPage, eventWasTrigger];
 }

 export default useInfiniteScroll;