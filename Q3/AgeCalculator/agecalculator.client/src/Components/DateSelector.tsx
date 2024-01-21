import { useState } from "react";

const DateSelector = ({onSubmit}:any) =>
{
    const [selectedDate, setSelectedDate] = useState('');

    const handleDateChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        const newDate = event.target.value;
        setSelectedDate(newDate);
    };

    return <>
        <form onSubmit={(e) => onSubmit(e, selectedDate)}>
            <label>Birthday: </label>
            <input type="date" id="birthday" name="birthday" placeholder="dd-mm-yyyy" pattern="\d{2}-\d{2}-\d{4}" value={selectedDate} onChange={handleDateChange} />
            <input type="submit" />
        </form>
    </>
}

export default DateSelector