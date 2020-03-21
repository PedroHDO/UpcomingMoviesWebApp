import React  from 'react';
import Moment from 'react-moment';

const DateFormater = ({dateToFormat}) => {
    const date = new Date(dateToFormat);
    return (<Moment date={date} format='LL'/>);
}
export default DateFormater;