import {  useEffect, useState } from "react";
import axios from 'axios'
import { List, ListItem, ListItemText, Typography } from "@mui/material"; 

function App() {
  const [events, setEvents] = useState<Events[]>([]);

  useEffect(() => {
    axios.get<Events[]>("https://localhost:5001/api/events")
      .then(res=> setEvents(res.data));

    return () => {};
  }, []);

  return (
    <>
      <Typography variant="h3">Eventify</Typography>
      <List>
        {events.map((event) => (
          <ListItem key={event.id}>
            <ListItemText>{event.title}</ListItemText>
          </ListItem>
        ))}
      </List>
    </>
  );
}

export default App;
