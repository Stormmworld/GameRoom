// import React from 'react';
// import Mana from '../../MtgGame/Components/Mana';
// import '../StyleSheets/WaitingRoomHeader.css';
// import Grid from 'material-ui';
// import { withStyles } from 'material-ui';


// const WaitingRoomHeader = (props) => {
//     return (
//         <Grid container >
//             <Grid item xs={1} ><Mana color='B' /></Grid>
//             <Grid item xs={1} ><Mana color='W' /></Grid>
//             <Grid item xs={1} ><Mana color='R' /></Grid>
//             <Grid item xs={1} ><Mana color='U' /></Grid>
//             <Grid item xs={1} ><Mana color='G' /></Grid>
//             <Grid item xs={2} >Five Color Lobby</Grid>
//             <Grid item xs={1} ><Mana color='B' /></Grid>
//             <Grid item xs={1} ><Mana color='W' /></Grid>
//             <Grid item xs={1} ><Mana color='R' /></Grid>
//             <Grid item xs={1} ><Mana color='U' /></Grid>
//             <Grid item xs={1} ><Mana color='G' /></Grid>
//         </Grid>
//     );
// }
// export default withStyles(styles)(WaitingRoomHeader);




import React from 'react';
import { Col } from 'react-bootstrap'
import Mana from '../../MtgGame/Components/Mana';
import '../StyleSheets/WaitingRoomHeader.css';


const WaitingRoomHeader = (props) => {
    return (
        <Col className="edgeless center-content name-container lobbyHeader" xs={12} sm={12} md={12} lg={12}>
            <Col className="edgeless center-content " xs={1} sm={1} md={1} lg={1}><Mana color='B' /></Col>
            <Col className="edgeless center-content " xs={1} sm={1} md={1} lg={1}><Mana color='W' /></Col>
            <Col className="edgeless center-content " xs={1} sm={1} md={1} lg={1}><Mana color='R' /></Col>
            <Col className="edgeless center-content " xs={1} sm={1} md={1} lg={1}><Mana color='U' /></Col>
            <Col className="edgeless center-content " xs={1} sm={1} md={1} lg={1}><Mana color='G' /></Col>
            <Col className="edgeless center-content " xs={2} sm={2} md={2} lg={2}>Five Color Lobby</Col>
            <Col className="edgeless center-content " xs={1} sm={1} md={1} lg={1}><Mana color='B' /></Col>
            <Col className="edgeless center-content " xs={1} sm={1} md={1} lg={1}><Mana color='W' /></Col>
            <Col className="edgeless center-content " xs={1} sm={1} md={1} lg={1}><Mana color='R' /></Col>
            <Col className="edgeless center-content " xs={1} sm={1} md={1} lg={1}><Mana color='U' /></Col>
            <Col className="edgeless center-content " xs={1} sm={1} md={1} lg={1}><Mana color='G' /></Col>
        </Col>
        
    );
}

export default WaitingRoomHeader;