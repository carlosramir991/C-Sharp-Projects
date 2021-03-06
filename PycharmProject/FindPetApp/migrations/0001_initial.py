# Generated by Django 2.2.5 on 2020-11-27 17:50

from django.db import migrations, models
import django.db.models.manager


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='AvailablePet',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(max_length=35)),
                ('age', models.DecimalField(decimal_places=2, max_digits=4)),
                ('birthday', models.DateField()),
                ('breed', models.CharField(max_length=25)),
                ('color', models.CharField(max_length=25)),
                ('animal', models.CharField(choices=[('Dog', 'Dog'), ('Cat', 'Cat')], max_length=10)),
                ('description', models.CharField(max_length=100)),
                ('location', models.CharField(max_length=2)),
            ],
            managers=[
                ('Availables', django.db.models.manager.Manager()),
            ],
        ),
    ]
