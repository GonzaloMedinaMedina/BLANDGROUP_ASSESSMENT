import { useState } from 'react';
import './App.css';
import DateSelector from './Components/DateSelector';

function App() {
    const [age, setAge] = useState(undefined);

    const getFormatDate = (date: Date) =>
    {
        let day = String(date.getDate()).padStart(2, '0');
        let month = String(date.getMonth() + 1).padStart(2, '0');
        let year = date.getFullYear();

        return `${day}/${month}/${year}`;
    }


    const fetchAge = async (event: Event, birthday: Date) =>
    {       
        event.preventDefault();
        const birthdayObject = new Date(birthday);

        if (birthdayObject > new Date())
        {
            alert("Introduce date values before todays date.")
            return;
        } 

        fetch('ageCalculator',
        {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(birthdayObject)
        })
        .then(response => response.json())
        .then(data =>
        {
            setAge(data);
        })
        .catch((error) => {
            console.log(error)
        })
    }

    const ageComponent = age !== undefined ?
        <p className="age">This is your exact age! {age.years} years, {age.months} months, {age.days} days, {age.hours} hours, {age.minutes} minutes, {age.seconds} seconds.</p> :
        null;

    return (

        <div className="page-container">
            <div className="header">
                <h1>Age calculator</h1>
            </div>
            <div className="content">
                {ageComponent}
                <p>Today's date: {getFormatDate(new Date())}</p>
                <DateSelector onSubmit={fetchAge}/>
            </div>
        </div>
    );
}

export default App;