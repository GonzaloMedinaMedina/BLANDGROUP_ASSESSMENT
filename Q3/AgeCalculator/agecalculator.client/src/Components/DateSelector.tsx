import { useState } from "react";

const DateSelector = ({onSubmit}) =>
{
    const [selectedDate, setSelectedDate] = useState('');

    const handleDateChange = (event) => {
        const newDate = event.target.value;
        setSelectedDate(newDate);
    };

    return <>
        <form onSubmit={(e) => onSubmit(e, selectedDate)}>
            <label>Birthday: </label>
            <input type="date" id="birthday" name="birthday" value={selectedDate} onChange={handleDateChange} />
            <input type="submit" />
        </form>
    </>
}

export default DateSelector