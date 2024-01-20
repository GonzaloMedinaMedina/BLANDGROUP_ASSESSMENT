import { useState } from 'react';
import './App.css';
import DateSelector from './Components/DateSelector';

function App() {
    const [age, setAge] = useState('');

    const getFormatDate = (date) =>
    {
        let day = String(date.getDate()).padStart(2, '0');
        let month = String(date.getMonth() + 1).padStart(2, '0');
        let year = date.getFullYear();

        return `${day}/${month}/${year}`;
    }


    const fetchAge = async (event, date) =>
    {        
        event.preventDefault();
        try
        {
            fetch('ageCalculator',
            {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(date)
                })
            .then(response => response.json())
            .then(data =>
            {
                console.log("dataaa" + data);
            })
        }
        catch (error)
        {
            console.error(error);
        }
    }

    return (

        <div className="page-container">
            <div className="header">
                <h1>Age calculator</h1>
            </div>
            <div className="content">
                <p>Today's date: {getFormatDate(new Date())}</p>
                <DateSelector onSubmit={fetchAge} />
            </div>
        </div>
    );
}

export default App;