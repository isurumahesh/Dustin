import { IconButton, Snackbar } from "@mui/material";
import CloseIcon from "@mui/icons-material/Close";

type Props = {
    snackBarOpen: boolean
    handleSnackBarClose: Function
    message: string
}
const SnackBarModal = ({ snackBarOpen, handleSnackBarClose, message }: Props) => {

    const action = (
        <>
            <IconButton
                size="small"
                aria-label="close"
                color="inherit"
                onClick={() => handleSnackBarClose()}
            >
                <CloseIcon fontSize="small" />
            </IconButton>
        </>
    );

    return (
        <Snackbar
            anchorOrigin={{ vertical: "bottom", horizontal: "right" }}
            open={snackBarOpen}
            autoHideDuration={6000}
            onClose={() => handleSnackBarClose()}
            message={message}
            action={action}
        />
    )
}

export default SnackBarModal;