import React from 'react';
import {Card, CardContent, CardHeader, makeStyles, Theme} from '@material-ui/core';

const useStyles = makeStyles((theme: Theme) => ({
    select: {
        width: theme.spacing(34)
    }
}));

const Landing = () => {
    const classes = useStyles();
    
    return(
        <div>
            <Card>
                <CardHeader title={'My Rad Site'} />
                <CardContent>
                    
                </CardContent>
            </Card>
        </div>
    );
}

export default Landing;