import fasttext

flevel_model = fasttext.train_supervised(input = "label12.train", epoch = 5000, lr = 0.25)
flevel_model.save_model("../models/label12_model")

