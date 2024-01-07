var Flower = {
    init: function () {
        $(document).on('click', '#saveFlower', function () {
            let flowerName = $('#flowerName').val();
            let flowerPrice = $('#flowerPrice').val();
            if (flowerName.length > 0 && flowerPrice.length > 0) {
                Flower.CreateNewFlower(flowerName, flowerPrice);
            }
        });

        $(document).on('click', '.delFlower', function () {
            let flowerId = $(this).data('id');
            if (flowerId > 0) {
                Flower.DeleteFlower(flowerId);
            }
        });
    },
    CreateNewFlower: function (name, price) {
        let flower = {};
        flower.id = 0;
        flower.flowerName = name;
        flower.price = price;
        $.ajax({
            url: "/flower/CreateFlower",
            type: 'POST',
            data: { flower: flower },
            success: function (response) {
                window.location.href = '/flower';
            },
            error: function (xhr, status, error) {
                console.error(error);
            }
        });
    },
    DeleteFlower: function (id) {
        $.ajax({
            url: "/flower/Delete",
            type: 'POST',
            data: { id : id },
            success: function (response) {
                window.location.href = '/flower';
            },
            error: function (xhr, status, error) {
                console.error(error);
            }
        });
    }
};
$(function () {
    Flower.init();
});