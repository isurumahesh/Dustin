import { Button, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle } from "@mui/material";

type Props = {
    handleDeleteModalClose: Function
    handleDeleteConfrim: Function
    deleteModalOpen: boolean
};

const DeleteConfirmationModal = ({ deleteModalOpen, handleDeleteModalClose, handleDeleteConfrim }: Props) => {

    return (
        <div>
            <Dialog open={deleteModalOpen} onClose={() => handleDeleteModalClose()}>
                <DialogTitle>Confirm Action</DialogTitle>
                <DialogContent>
                    <DialogContentText>
                        Are you sure you want to delete?
                    </DialogContentText>
                </DialogContent>
                <DialogActions>
                    <Button onClick={() => handleDeleteModalClose()} color="secondary">
                        Cancel
                    </Button>
                    <Button onClick={() => handleDeleteConfrim()} color="primary" variant="contained">
                        Confirm
                    </Button>
                </DialogActions>
            </Dialog>
        </div>
    );
}

export default DeleteConfirmationModal;